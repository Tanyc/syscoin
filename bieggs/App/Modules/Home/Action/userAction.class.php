<?php

class userAction extends loginAction{
	function _initialize() {
        parent::_initialize();
        $this->assign('PAGE_CURID',7);
    }

    public function index(){
    	$this->assign('PAGE_NAVII',0); //基本信息

        $db_user = D('User');
        // $db_user_id = $db_user->getUserByid('1873372'); //测试，后期查询自己的数据
        $this->assign("db_user_id",$db_user->getUserSet());

        $this->display();
    }

    public function edit(){
        $this->assign('PAGE_NAVII',1); //修改资料
        
        $this->display();
    }

    public function secure(){
        $this->assign('PAGE_NAVII',2); //身份认证/绑定手机
        
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
    	
        $this->display();
    }

    public function myprize(){
        $this->assign('PAGE_NAVII',5); //我的兑奖
        
        $this->display();
    }

    public function putad(){
        $this->assign('PAGE_NAVII',6); //修改密码
        
        $this->display();
    }

    public function myad(){
        $this->assign('PAGE_NAVII',7); //投放广告
        
        $this->display();
    }

    public function descad(){
        $this->assign('PAGE_NAVII',8); //我的广告
        
        $this->display();
    }

    public function tooluse(){
        $this->assign('PAGE_NAVII',9); //道具使用
        
        $this->display();
    }

    public function vipget(){
        $this->assign('PAGE_NAVII',10); //vip每日领取
        
        $this->display();
    }

    public function salary(){
        $this->assign('PAGE_NAVII',11); //工资领取
        
        $this->display();
    }

    public function myfriend(){
        $this->assign('PAGE_NAVII',12); //工资领取
        
        $this->display();
    }

    public function invite(){
        $this->assign('PAGE_NAVII',13); //工资领取
        
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
    
}