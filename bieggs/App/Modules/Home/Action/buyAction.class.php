<?php

class buyAction extends Action{
    public function index(){
    	$this->assign('curID',3);
        $this->display();
    }
}