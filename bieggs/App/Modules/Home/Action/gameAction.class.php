<?php
class gameAction extends comAction{

    function _initialize() {
        parent::_initialize();
        Log::record("gameAction _initialize...");
        $this->assign('PAGE_CURID',4);
    }

    public function initCom($db_data_cnt, $cur_pg){
        $array['db_data_cnt'] = $db_data_cnt;    //总数
        $array['cur_pg']      = $cur_pg; //当前页
        $this->assign($array);
    }

    public function index(){
        $this->assign('GAME_TAB',1);

        $pg = $this->_param('pg');
        $pc28 = D("Pc28");
        $this->assign("db_pc28",$pc28->getResult($pg));

        $this->initCom($pc28->getCount(),("" == $pg)? 1 : $pg);

        $this->display();
    }

    public function pg310(){
        $this->assign('GAME_TAB',2);

        $pg = $this->_param('pg');
        $pc310 = D("Pc310");
        $this->assign("db_pc310",$pc310->getResult($pg));

        $this->initCom($pc310->getCount(),("" == $pg)? 1 : $pg);

        $this->display();
    }

    public function pgstar(){
        $this->assign('GAME_TAB',3);

        $this->display();
    }

}