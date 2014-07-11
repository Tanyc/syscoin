<?php

class bbsAction extends comAction{
	function _initialize() {
        parent::_initialize();
        $this->assign('PAGE_CURID',9);
    }

    public function index(){
        $this->display();
    }

    public function pjudge(){
        $this->display();
    }
}