<?php

class activityAction extends Action{
    public function index(){
    	$this->assign('PAGE_CURID',5);
        $this->display();
    }

}