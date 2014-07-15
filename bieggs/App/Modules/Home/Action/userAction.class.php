<?php

class userAction extends Action{
	function _initialize() {
        $this->assign('PAGE_CURID',7);
    }

    public function index(){
    	$this->assign('PAGE_NAVII',0); //基本信息
        $this->display();
    }

    public function account(){
    	$this->assign('PAGE_NAVII',1); //基本信息
    	$sub_tab = ("" == $this->_param("sub_tab"))? 0 : $this->_param("sub_tab");
    	$this->assign('SUB_TAB',$sub_tab); //重属tab
    	
        $this->display();
    }

    public function myprize(){
        $this->assign('PAGE_NAVII',2); //我的兑奖
        
        $this->display();
    }

    public function edit(){
        $this->assign('PAGE_NAVII',3); //修改资料
        
        $this->display();
    }

    public function secure(){
        $this->assign('PAGE_NAVII',4); //安全认证
        
        $this->display();
    }

    public function userpwd(){
        $this->assign('PAGE_NAVII',5); //修改密码
        
        $this->display();
    }

}