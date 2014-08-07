<?php

class pubtplAction extends Action{
    public function nologin(){
    	$this->display();
    }

    public function exitLogin(){
        cookie(C("COOKIE_ID"),null);  //delete cookie
        cookie(C("COOKIE_AUTH"),null);
        if(isset($_SESSION[C('USER_AUTH_KEY')])) {
            unset($_SESSION[C('USER_AUTH_KEY')]);
            unset($_SESSION);
            session_destroy();
            $this->success('登出成功！','./nologin');
        } else {
            $this->error('已经登出！');
        }
    }
    
    function login(){
        if($_SESSION['online'] == 1){
            Log::record("dingyong's test............11");
            $this->error('已经登录');
        }
        Log::record("dingyong's test............");
        if(!verifyName($_POST['txt_UserName'])) {
            $this->error('用户名不合法，请核实！');
        }elseif (!verifyKey($_POST['txt_PWD'])){
            $this->error('密码长度不合法，请核实！');
        }elseif (!verifyCode($_POST['txt_VerifyCode'])){
            $this->error('验证码长度不合法，请核实！');
        }
        if(session('verify') != md5($_POST['txt_VerifyCode'])){
            $this->error('验证码错误！');
        }
        //生成认证条件
        $map            =   array();
        $map['email'] = $_POST['txt_UserName']; //use email for account name
        $authInfo = M('User')->where($map)->find();
        if(false == $authInfo) {
            $this->error('帐号不存在,请核对！');
        } else {
            if($authInfo['key'] != md5($_POST['txt_PWD'])) {
                $this->error('密码错误！');
            }
            if (isset($_POST["LoginWay"])) { //auto login in three days
                cookie(C("COOKIE_ID"),$authInfo['id'],60 * 60 * 24 * 3);  //keep three days time
                cookie(C("COOKIE_AUTH"),md5($authInfo['email']),60 * 60 * 24 * 3);
            }
            setUserInfo($authInfo); //save info to seesion
            updateUserInfo();       //update login info
            // redirect(__ROOT__.'/user/index');
            $this->success('登录成功！',__ROOT__.'/user/index');
        }
    }

    public function verify() {
        $type    =   isset($_GET['type'])?$_GET['type']:'png';
        import("@.ORG.Util.Image");
        $verifyCode = Image::buildImageVerify(4,1,$type);
    }

    public function checkCode(){
        $code = $this->_param("code");
        if(session('verify') == md5($code)){
            $this->ajaxReturn("ok");
        }else{
            $this->ajaxReturn("false");
        }
    }

    public function dlg(){
        
    }

}