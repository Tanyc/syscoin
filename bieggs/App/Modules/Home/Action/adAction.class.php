<?php

class adAction extends Action{
    public function index(){
    	$this->assign('curID',2);
        $this->display();
    }

}