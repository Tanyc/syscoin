<?php

class pubtplAction extends Action{
    public function nologin(){
        if(isset($_SESSION[C('USER_AUTH_KEY')])) {
            redirect(__ROOT__.'/user/index');
            return;
        }
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
        if(!isCodeRight($_POST['txt_VerifyCode'])){
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
        $dlg_from = $this->_param('dlg_from');
        $key1 = $this->_param('first_key');
        $key2 = $this->_param('second_key');
        $code = $this->_param('txt_VerifyCode');
        if (!verifyKey($key1)/* || !verifyKey($key2) */|| !verifyCode($code)) {
            $this->assign("is_success",'2');
            $this->assign("error_msg",'你的操作非法！');
            $this->display('dlg:snumin');
            return;
        }
        if (!isCodeRight($code)){
            $this->assign("is_success",'2');
            $this->assign("error_msg",'验证码错误！');
        } else {
            $db_user = D('User');
            $authInfo = $db_user->getAuthInfo();
            if (md5($key1) != $authInfo['key']) {
                $this->assign("is_success",'2');
                $this->assign("error_msg",'你的密码错误！');
                $this->display('dlg:snumin');
                return;
            }
            switch ($dlg_from) {
                case '2':
                case '4':
                    if(md5($key2) != $authInfo['s_key']){
                        $this->assign("is_success",'2');
                        $this->assign("error_msg",'你的密码错误！');
                        $this->display('dlg:snumin');
                        return;
                    }
                    break;
                default:
                    break;
            }
            if (2 == $dlg_from) { //modify sms_open
                $switch = ($authInfo["s_message"] == 1)? 0 : 1;
                $db_user->updateField("s_message",$switch);
            } elseif (4 == $dlg_from) {
                $switch = ($authInfo["sms_login"] == 1)? 0 : 1;
                $db_user->updateField("sms_login",$switch);
            } elseif (6 == $dlg_from){
                $db_user->updateField("nick",$key2);
            } elseif (7 == $dlg_from){
                $db_user->updateField("s_addr",$key2);
            } elseif (8 == $dlg_from){
                $db_user->updateField("desc",$key2);
            }
            $this->assign("is_success",'1');
        }
        $this->display('dlg:snumin');
    }

}