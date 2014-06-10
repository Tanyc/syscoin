<?php

class adAction extends Action{
    public function index(){
    	$this->assign('curID',2);
        $tiyan = D("Tiyan");
        $this->assign('tiyan',$tiyan->getList());
        $this->display();
    }

    public function play(){
    	$this->assign('curID',2);
    	$this->assign('tab',2);
        $this->display('index');
    }

    public function check(){
    	$this->assign('curID',2);
    	$this->assign('tab',3);
        $this->display('index');
    }

}