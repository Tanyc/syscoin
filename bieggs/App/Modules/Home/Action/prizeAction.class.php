<?php
class prizeAction extends Action{
    public function index(){
    	$this->assign('curID',6);
        $this->display();
    }
}