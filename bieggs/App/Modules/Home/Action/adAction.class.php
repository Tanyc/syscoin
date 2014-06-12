<?php

class adAction extends adComAction{
    public function index(){
        $M_TAB = 1;
        $this->assign('db_tiyan',$this->tiyan->getListByTab($M_TAB));
        $this->display();
    }

    public function play(){
        $M_TAB = 2;
    	$this->assign('m_tab',$M_TAB); //tab页面
        $this->assign('db_tiyan',$this->tiyan->getListByTab($M_TAB));
        $this->display('index');
    }

    public function check(){
        $M_TAB = 3;
    	$this->assign('m_tab',$M_TAB); //tab页面
        $this->assign('db_tiyan',$this->tiyan->getListByTab($M_TAB));
        $this->display('index');
    }

}