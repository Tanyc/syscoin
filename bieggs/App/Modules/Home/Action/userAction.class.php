<?php

class userAction extends loginAction{
	function _initialize() {
        parent::_initialize();
        $this->assign('PAGE_CURID',7);
    }

    public function index(){
    	$this->assign('PAGE_NAVII',0); //基本信息
        $this->assign("db_user",D('User')->getUserSet());

        $this->display();
    }

    public function edit(){
        $this->assign('PAGE_NAVII',1); //修改资料
        $this->assign("db_user",D('User')->getUserSet());
        
        $this->display();
    }

    public function secure(){
        $this->assign('PAGE_NAVII',2); //身份认证/绑定手机
        $authInfo = D('User')->getAuthInfo();
        if ("" != $authInfo["s_name"]) {
            $array['s_name'] = convSeMsg($authInfo["s_name"],3); 
        }
        if ("" != $authInfo["s_number"]) {
            $array['s_num']  = convSeMsg($authInfo["s_number"],5); 
        }
        if ("" != $authInfo["phone"]) {
            $array['phone']  = convSeMsg($authInfo["phone"],5); 
        }
        $this->assign($array);
        $this->display();
    }

    public function userpwd(){
        $this->assign('PAGE_NAVII',3); //修改密码/密保
        
        $this->display();
    }

    public function account(){
    	$this->assign('PAGE_NAVII',4); //账号明细
    	$sub_tab = ("" == $this->_param("sub_tab"))? 0 : $this->_param("sub_tab");
    	$this->assign('SUB_TAB',$sub_tab); //重属tab

        $UID = $_SESSION[C('USER_AUTH_KEY')];

        $db_user_eggs = M("UserEggs");
        $data = $db_user_eggs->where('UID='.$UID)->select();
    	$this->assign('db_user_eggs',$data); //重属tab

        $index = isNil($this->_param("pg"))? 1 : $this->_param("pg");
        $pagedata = $db_user_eggs->page($index,10)->select();
        $this->assign('db_user_pageeggs',$pagedata); //所有金蛋

        $this->initCom($db_user_eggs->count(),$index);
        $this->display();
    }

    private function initCom($db_data_cnt, $cur_pg){
        $array['db_data_cnt'] = $db_data_cnt;    //总数
        $array['cur_pg']      = $cur_pg; //当前页
        $array['items']      = 10; //每页显示的条数
        $this->assign($array);
    }

    public function myprize(){
        $this->assign('PAGE_NAVII',5); //我的兑奖
        $UID = $_SESSION[C('USER_AUTH_KEY')];
        
        $db_duijiang = M("Duijiang");
        $index = isNil($this->_param("pg"))? 1 : $this->_param("pg");
        $pagedata = $db_duijiang->where("user_id=".$UID)->order("state ASC")->page($index,10)->select();
        $this->assign('db_duijiang',$pagedata); 
        $this->initCom($db_duijiang->count(),$index);

        $db_user_addr = M("UserAddr");
        $addrdata = $db_user_addr->where("UID=".$UID)->select();
        $cnt = $db_user_addr->where("UID=".$UID)->count();
        $this->assign('db_user_addr',$addrdata);
        $this->assign('db_user_addr_cnt',$cnt);

        $this->display();
    }

    public function myad(){
        $this->assign('PAGE_NAVII',6); //投放广告
        
        $this->display();
    }

    public function desad(){
        $this->assign('PAGE_NAVII',7); //广告介绍
        
        $this->display();
    }

    public function tooluse(){
        $this->assign('PAGE_NAVII',8); //道具使用
        
        $this->display();
    }

    public function vipget(){
        $this->assign('PAGE_NAVII',9); //vip每日领取
        
        $this->display();
    }

    public function salary(){
        $this->assign('PAGE_NAVII',10); //工资领取
        
        $this->display();
    }

    public function myfriend(){
        $this->assign('PAGE_NAVII',11); //工资领取
        
        $this->display();
    }

    public function invite(){
        $this->assign('PAGE_NAVII',12); //工资领取
        
        $this->display();
    }

    public function ssetting(){
        $SAFE_TYPE=array("SNUMBER"=>"0","IPLIMIT"=>"1","SMESSAGE"=>"2","SBANKKEY"=>"3","SMSLOGIN"=>"4");
        $id = $this->_param("id");
        // switch ($id) {
        //     case $SAFE_TYPE["SNUMBER"]:
        //         $db_user = D('User');
        //         $db_user->updateField("s_number","123456789");
        //         break;
        //     case $SAFE_TYPE["IPLIMIT"]:
        //         # code...
        //         break;
        //     case $SAFE_TYPE["SMESSAGE"]:
        //         # code...
        //         break;
        //     case $SAFE_TYPE["SBANKKEY"]:
        //         # code...
        //         break;
        //     case $SAFE_TYPE["SMSLOGIN"]:
        //         # code...
        //         break;
        //     default:
        //         break;
        // }
        // //中间处理一下业务逻辑
        $this->ajaxReturn($id);
    }

    public function secureMod(){
        if(!isCodeRight($_POST['txt_VerifyCode'])){
            $this->error('验证码非法！');
        }
        $s_name = $_POST["s_name"];
        $s_num = $_POST["s_num"];
        if (!checkName($s_name)) {
            $this->error("姓名输入非法");
        };
        if (!checkSCard($s_num)) {
            $this->error("身份证号输入非法");
        };
        $data['s_name'] = $s_name;
        $data['s_number'] = $s_num;
        $result = D("User")->updateFields($data);
        if ($result) {
            $this->success();
        }else{
            $this->error("更新信息失败！");
        } 
    }

    public function phCheck(){  //phone security check
        
    }

    public function pwdchange(){ //password change
        $oldp = $_POST["OLDPASSWORD"];
        $newp = $_POST["NEWPASWWORD"];
        $renewp = $_POST["NEWPASWWORD2"];
        if (verifyKey($newp) && $newp == $renewp) {
            $user_db = D("User");
            $authInfo = $user_db->getAuthInfo();
            if ($authInfo["key"] != md5($oldp)) {
                $this->error("你的登录密码不正确！");
            }
            $user_db->updateField("key",md5($newp));
            $this->success();
        }else{
            $this->error("输入非法！");
        }
    }

    public function infoMod(){
        $user_db = D("User");
        $authInfo = $user_db->getAuthInfo();
        if ($_POST["headimg"] && "" != $_POST["headimg"]) {
            $user_db->updateField("headimg",$_POST["headimg"]);
        } else {
            if ($_POST["nick"] && "" != $_POST["nick"]) {
                if ("" == $authInfo["nick"]) {
                    $user_db->updateField("nick",$_POST["nick"]);
                }
            }
            if ($_POST["qq"] && "" != $_POST["qq"]) {
                // if (!verifyPhone($_POST["qq"])) {
                //     $this->error('操作非法！');
                //     return;
                // }
                if ("" == $authInfo["qq"]) {
                    $user_db->updateField("qq",$_POST["qq"]);
                }
            }
            if ($_POST["phone"] && "" != $_POST["phone"]) {
                if (!verifyPhone($_POST["phone"])) {
                    $this->error('操作非法！');
                    return;
                }
                if ("" == $authInfo["phone"]) {
                   $user_db->updateField("phone",$_POST["phone"]);
                }
            }
            if ($_POST["s_addr"] && "" != $_POST["s_addr"]) {
                $user_db->updateField("s_addr",$_POST["s_addr"]);
            }
            if ($_POST["desc"] && "" != $_POST["desc"]) {
                $user_db->updateField("desc",$_POST["desc"]);
            }
        }
        $this->success();
    }

    public function addAddr(){
        $db_user_addr = M("UserAddr");
        $UID              = $_SESSION[C('USER_AUTH_KEY')];

        $data['UID']      = $_SESSION[C('USER_AUTH_KEY')];
        $data['NAME']     = $_POST["NAME"];
        $data['PROVINCE'] = $_POST["PROVINCE"];
        $data['CITY']     = $_POST["CITY"];
        $data['ADDRESS']  = $_POST["ADDRESS"];
        $data['PCODE']    = $_POST["PCODE"];
        $data['TEL']      = $_POST["TEL"];
        if (isset($_POST["ISMODE"])) {
            $db_user_addr->where("id=".$_POST["ISMODE"]." and UID=".$UID)->save($data);
        }else{
            $db_user_addr->add($data);
        }
        $this->success();
    }

    public function modaddr(){
        $db_user_addr = M("UserAddr");
        $addrdata = $db_user_addr->where("UID=".$UID)->select();
        $this->assign('db_user_addr',$addrdata);
    }

    public function deladdr(){
        $id = $this->_param("id");
        $UID = $_SESSION[C('USER_AUTH_KEY')];

        $db_user_addr = M("UserAddr");
        $addrdata = $db_user_addr->where("id=".$id." and UID=".$UID)->delete();
        $this->success();
    }
    
}