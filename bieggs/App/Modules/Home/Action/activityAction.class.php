<?php

class activityAction extends Action{
    public function index(){
    	$this->assign('curID',5);
        $this->display();
    }

}