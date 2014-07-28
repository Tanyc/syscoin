/*#include "stdafx.h"
extern "C" { 
	#include "lua.h" 
	#include "lualib.h" 
	#include "lauxlib.h" 
}
#include "string.h"
#include <stdarg.h>

lua_State* L;*/
 
/*void call_va (const char *func, const char *sig, ...) {
    va_list vl;
    int narg, nres;  
    va_start(vl, sig);
    lua_getglobal(L, func);  
    narg = 0;
    while (*sig) { 
       switch (*sig++) {
       case 'd':
           lua_pushnumber(L, va_arg(vl, double));
           break;
       case 'i': 
           lua_pushnumber(L, va_arg(vl, int));
           break;
       case 's': 
           lua_pushstring(L, va_arg(vl, char *));
           break;
       case '>':
           goto endwhile;
       default:
           	printf( "error happen in call_va"); 
       }
       narg++;
       luaL_checkstack(L, 1, "too many arguments");
    } endwhile:
    nres = strlen(sig);
    lua_call(L, 2, 1);
    nres = -nres; 
    while (*sig) {  
       switch (*sig++) {
       case 'd': 
           if (!lua_isnumber(L, nres))
			   	printf( "error happen3"); 
              //error(L, "wrong result type");
           *va_arg(vl, double *) = lua_tonumber(L, nres);
           break;
       case 'i':
           if (!lua_isnumber(L, nres))
					printf( "error happen4"); 
              //error(L, "wrong result type");
           *va_arg(vl, int *) = (int)lua_tonumber(L, nres);
           break;
       case 's':
           if (!lua_isstring(L, nres))
				printf( "error happen5"); 
              //error(L, "wrong result type");
           *va_arg(vl, const char **) = lua_tostring(L, nres);
           break;
       default:
				printf( "error happen6"); 
           //error(L, "invalid option (%c)", *(sig - 1));
       }
       nres++;
    }
    va_end(vl);
}*/

/*
int luaadd ( int x, int y ) 
{ 
    int sum, sum1; 
    lua_getglobal(L, "add"); 
    lua_pushnumber(L, x); 
    lua_pushnumber(L, y); 
    lua_call(L, 2, 2); 
    sum = (int)lua_tointeger(L, -1); 
	sum1 = (int)lua_tointeger(L, -1);  //返回栈顶元素，返回双值的函数调用
	printf( "The return value sum1 is %d\n", sum1); 
    lua_pop(L, 1); 
    return sum; 
} 

void myPrint(){
	lua_getglobal(L,"myprint");
	lua_call(L,0,0);
	int retuenV = (int)lua_tointeger(L,-1);
	printf( "The return value is %d\n", retuenV ); 
}
 
int main ( int argc, char *argv[] ) { 
    int sum; 
    L = lua_open(); 
    luaL_openlibs(L); 
    luaL_dofile(L, "add.lua"); 
    sum = luaadd( 200, 50 ); 
	myPrint();
    printf( "The sum is %d\n", sum ); 
    lua_close(L); 
    return 0; 
} 
*/
/***********************第一个示例**************************/
/*#include "stdafx.h"
#include <string.h>
extern "C"{
	#include <lua.h>
	#include <lauxlib.h>
	#include <lualib.h> 
}
#define MAX_COLOR 255

struct ColorTable {
    char *name;
    unsigned char red, green, blue;
} colortable[] = {
    {"WHITE",  MAX_COLOR, MAX_COLOR, MAX_COLOR},
    {"RED",    MAX_COLOR, 0,         0},
    {"GREEN",  0,         MAX_COLOR, 0},
    {"BLUE",   0,         0,         MAX_COLOR},
    {"BLACK",  0,         0,         0},
    {NULL,     0,         0,         0}
};

int main (void){
    char buff[256];
    int error;
    lua_State *L = lua_open();
	luaL_openlibs(L);
    while (fgets(buff, sizeof(buff), stdin) != NULL) {
       error = luaL_loadbuffer(L, buff, strlen(buff),  //luaL_loadbuffer编译输入的lua代码，调用返回零并把编译之后的chunk压入栈，lua_pcall将会把chunk从栈中弹出并在保护模式下运行它
                  "line") || lua_pcall(L, 0, 0, 0);
       if (error) {
           fprintf(stderr, "%s", lua_tostring(L, -1));
           lua_pop(L, 1);
       }
    }
    lua_close(L);
    return 0;
}*/

/*******************lua调用C示例*************************/
#include "stdafx.h"
#include <stdio.h>
#include <string.h>
#include <lua.hpp>
#include <lauxlib.h>
#include <lualib.h>
  
  //待Lua调用的C注册函数。
static int add2(lua_State* L){
     //检查栈中的参数是否合法，1表示Lua调用时的第一个参数(从左到右)，依此类推。
     //如果Lua代码在调用时传递的参数不为number，该函数将报错并终止程序的执行。
     double op1 = luaL_checknumber(L,1);
     double op2 = luaL_checknumber(L,2);
     //将函数的结果压入栈中。如果有多个返回值，可以在这里多次压入栈中。
     lua_pushnumber(L,op1 + op2);
     //返回值用于提示该C函数的返回值数量，即压入栈中的返回值数量。
     return 1;
 }
 //另一个待Lua调用的C注册函数。
 static int sub2(lua_State* L){
     double op1 = luaL_checknumber(L,1);
     double op2 = luaL_checknumber(L,2);
     lua_pushnumber(L,op1 - op2);
     return 1;
 }
 
 const char* testfunc = "print(add(200,300)) print(sub(50.1,10))";
 
 int main(){
     lua_State* L = lua_open(); //luaL_newstate();  //两种获取lua_State的方法
     luaL_openlibs(L);
     //将指定的函数注册为Lua的全局函数变量，其中第一个字符串参数为Lua代码
     //在调用C函数时使用的全局函数名，第二个参数为实际C函数的指针。
	 /***第一种注册函数的方法***/
	 lua_pushcfunction(L, add2);
	 lua_setglobal(L, "add");   //映射成lua可以调用的函数名
	 lua_pushcfunction(L, sub2);
	 lua_setglobal(L, "sub");
	 /***第二种注册函数的方法***/
     /*lua_register(L, "add2", add2);  //映射成lua可以调用的函数名
     lua_register(L, "sub2", sub2);*/
     //在注册完所有的C函数之后，即可在Lua的代码块中使用这些已经注册的C函数了。
     if (luaL_dostring(L,testfunc))  //执行一条lua语句
         printf("Failed to invoke.\n");
     lua_close(L);
     return 0;
 }