<?php

class adAction extends Action{
    public function index(){
    	$this->assign('curID',2);

        $tiyan = D("Tiyan");
        $this->assign('tiyan',$tiyan->getTiyanList());

        $this->display();
    }

    public function play(){
    	$this->assign('curID',2);
    	$this->assign('tab',2);

        $tiyan = D("Tiyan");
        $this->assign('tiyan',$tiyan->getShiwanList());
        $this->display('index');
    }

    public function check(){
    	$this->assign('curID',2);
    	$this->assign('tab',3);

        $tiyan = D("Tiyan");
        $this->assign('tiyan',$tiyan->getDiaochaList());
        $this->display('index');
    }

}