<?php

class pubtplAction extends Action{
    public function nologin(){
    	$this->display();
    }

    public function exitLogin(){
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
        $map['email'] = $_POST['txt_UserName']; //使用email作为账户名称
        $authInfo = M('User')->where($map)->find();
        //使用用户名、密码和状态的方式进行认证
        if(false == $authInfo) {
            $this->error('帐号不存在,请核对！');
        } else {
            if($authInfo['key'] != md5($_POST['txt_PWD'])) {
                $this->error('密码错误！');
            }
            $_SESSION['online']           = 1; //1表示在线，0表示离线，给客户端展示
            $_SESSION[C('USER_AUTH_KEY')] = $authInfo['id'];
            $_SESSION['id']               = $authInfo['id'];
            $_SESSION['headimg']          = $authInfo['headimg'];
            $_SESSION['email']            = $authInfo['email'];
            $_SESSION['nick']             = $authInfo['nick'];
            $_SESSION['vip']              = $authInfo['vip'];
            $_SESSION['ltime']            = $authInfo['ltime'];
            $_SESSION['lip']              = $authInfo['lip'];
            //保存登录信息
            $User   =   M('User');
            $data                   = array();
            $data['id']             = $authInfo['id'];
            $data['ltime']          = time();
            $data['lip']            = get_client_ip();
            $User->save($data);
            // redirect(__ROOT__.'/user/index');
            $this->success('登录成功！',__ROOT__.'/user/index');
        }
    }

    public function verify() {
        $type    =   isset($_GET['type'])?$_GET['type']:'png';
        import("@.ORG.Util.Image");
        $verifyCode = Image::buildImageVerify(4,1,$type);
    }

    public function verRefresh(){
        // import("@.ORG.Util.Image");
        // $verifyCode = Image::buildImageVerify(4,1,$type);
        $this->ajaxReturn(mytest1());
    }

}