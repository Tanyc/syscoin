<?php

class adAction extends comAction{

    var $tiyan,$tylast,$niu;
    
    function _initialize() {
        parent::_initialize();
        Log::record("adAction _initialize...");
        $this->assign('PAGE_CURID',2);
        $this->tiyan = D("Tiyan");
        $this->tylast= D("Tiyanlast");
        $this->niu = D("Niu");

        $this->assign('db_tylast',$this->tylast->getTylastList());
        $this->assign('db_slider',$this->tiyan->getSliderList());
        $this->assign('db_niu',$this->niu->getSpecList(null,"data_id=1 or 2"));
    }

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