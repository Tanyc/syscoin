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
	sum1 = (int)lua_tointeger(L, -1);  //����ջ��Ԫ�أ�����˫ֵ�ĺ�������
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
/***********************��һ��ʾ��**************************/
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
       error = luaL_loadbuffer(L, buff, strlen(buff),  //luaL_loadbuffer���������lua���룬���÷����㲢�ѱ���֮���chunkѹ��ջ��lua_pcall�����chunk��ջ�е������ڱ���ģʽ��������
                  "line") || lua_pcall(L, 0, 0, 0);
       if (error) {
           fprintf(stderr, "%s", lua_tostring(L, -1));
           lua_pop(L, 1);
       }
    }
    lua_close(L);
    return 0;
}*/

/*******************lua����Cʾ��*************************/
#include "stdafx.h"
#include <stdio.h>
#include <string.h>
#include <lua.hpp>
#include <lauxlib.h>
#include <lualib.h>
  
  //��Lua���õ�Cע�ắ����
static int add2(lua_State* L){
     //���ջ�еĲ����Ƿ�Ϸ���1��ʾLua����ʱ�ĵ�һ������(������)���������ơ�
     //���Lua�����ڵ���ʱ���ݵĲ�����Ϊnumber���ú�����������ֹ�����ִ�С�
     double op1 = luaL_checknumber(L,1);
     double op2 = luaL_checknumber(L,2);
     //�������Ľ��ѹ��ջ�С�����ж������ֵ��������������ѹ��ջ�С�
     lua_pushnumber(L,op1 + op2);
     //����ֵ������ʾ��C�����ķ���ֵ��������ѹ��ջ�еķ���ֵ������
     return 1;
 }
 //��һ����Lua���õ�Cע�ắ����
 static int sub2(lua_State* L){
     double op1 = luaL_checknumber(L,1);
     double op2 = luaL_checknumber(L,2);
     lua_pushnumber(L,op1 - op2);
     return 1;
 }
 
 const char* testfunc = "print(add(200,300)) print(sub(50.1,10))";
 
 int main(){
     lua_State* L = lua_open(); //luaL_newstate();  //���ֻ�ȡlua_State�ķ���
     luaL_openlibs(L);
     //��ָ���ĺ���ע��ΪLua��ȫ�ֺ������������е�һ���ַ�������ΪLua����
     //�ڵ���C����ʱʹ�õ�ȫ�ֺ��������ڶ�������Ϊʵ��C������ָ�롣
	 /***��һ��ע�ắ���ķ���***/
	 lua_pushcfunction(L, add2);
	 lua_setglobal(L, "add");   //ӳ���lua���Ե��õĺ�����
	 lua_pushcfunction(L, sub2);
	 lua_setglobal(L, "sub");
	 /***�ڶ���ע�ắ���ķ���***/
     /*lua_register(L, "add2", add2);  //ӳ���lua���Ե��õĺ�����
     lua_register(L, "sub2", sub2);*/
     //��ע�������е�C����֮�󣬼�����Lua�Ĵ������ʹ����Щ�Ѿ�ע���C�����ˡ�
     if (luaL_dostring(L,testfunc))  //ִ��һ��lua���
         printf("Failed to invoke.\n");
     lua_close(L);
     return 0;
 }