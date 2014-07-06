<?php
class mybetsAction extends loginAction{
    function _initialize() {
        parent::_initialize();
        $this->assign('PAGE_CURID',4);
    }

    public function my28(){
        $this->display("my28");
    }

    public function my310(){
        $this->display("my310");
    }

}