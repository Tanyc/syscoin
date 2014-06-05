<?php
class investAction extends Action{
    public function index(){
    	$this->assign('curID',10);
        $this->display();
    }
}