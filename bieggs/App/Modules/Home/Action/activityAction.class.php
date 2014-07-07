<?php

class activityAction extends comAction{
	function _initialize() {
        parent::_initialize();
        $this->assign('PAGE_CURID',5);
    }
    public function index(){
    	$this->assign('ACT_TAB',1);
    	$active = D("Activity");
    	$this->assign('db_activity',$active->getActiveList());

        $this->display();
    }

    public function pasact(){
    	$this->assign('ACT_TAB',0);
    	$active = D("Activity");
    	$this->assign('db_activity',$active->getInActiveList());

        $this->display('index');
    }

}