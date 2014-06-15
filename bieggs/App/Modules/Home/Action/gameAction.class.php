<?php
class gameAction extends comAction{
    function _initialize() {
        Log::record("gameAction _initialize...");
        $this->assign('PAGE_CURID',4);
    }

    public function index(){
        $pc28 = D("Pc28");
        $this->assign("db_pc28",$pc28->getResult(1));
        $this->display();
    }

    public function pg310(){
        $this->display();
    }

    public function pgstar(){
        $this->display();
    }
}