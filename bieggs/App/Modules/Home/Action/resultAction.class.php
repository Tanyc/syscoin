<?php
class resultAction extends comAction{

    function _initialize() {
        parent::_initialize();
        Log::record("resultAction _initialize...");
        $this->assign('PAGE_CURID',4);
    }

    public function index(){
        $LID = $this->_param('LID');
        $pg = $this->_param('pg');
        $result = D("Result");
        $this->assign("db_result",$result->getResult($LID,$pg));

        $this->initCom($LID,$result->getCount(),("" == $pg)? 1 : $pg);

        $this->display();
    }

    public function initCom($LID,$db_data_cnt, $cur_pg){
        $array['LID'] = $LID;    //总数
        $array['db_data_cnt'] = $db_data_cnt;    //总数
        $array['cur_pg']      = $cur_pg; //当前页
        $this->assign($array);
    }
}