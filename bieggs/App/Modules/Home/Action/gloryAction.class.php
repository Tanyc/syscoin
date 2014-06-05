<?php
class gloryAction extends Action{
    public function index(){
    	$this->assign('curID',8);
        $this->display();
    }
}