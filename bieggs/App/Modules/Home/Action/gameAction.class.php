<?php
class gameAction extends comAction{
    function _initialize() {
        parent::_initialize();
        Log::record("gameAction _initialize...");
        $this->assign('PAGE_CURID',4);
    }

    public function index(){
        $this->assign('GAME_TAB',1);

        $pc28 = D("Pc28");
        $this->assign("db_pc28",$pc28->getResult(1));
        $this->display();
    }

    public function pg310(){
        $this->assign('GAME_TAB',2);

        $pc310 = D("Pc310");
        $this->assign("db_pc310",$pc310->getResult(1));
        $this->display();
    }

    public function pgstar(){
        $this->assign('GAME_TAB',3);

        $this->display();
    }
}