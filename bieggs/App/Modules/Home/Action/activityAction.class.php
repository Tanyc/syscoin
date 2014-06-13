<?php

class activityAction extends comAction{
    public function index(){
    	$this->assign('PAGE_CURID',5);
        $this->display();
    }

}