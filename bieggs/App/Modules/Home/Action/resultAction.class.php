<?php
class resultAction extends comAction{

    function _initialize() {
        parent::_initialize();
        Log::record("resultAction _initialize...");
        $this->assign('PAGE_CURID',4);
    }

    public function index(){
        $LID = $this->_param('LID');
        if ("" == $LID) {
           redirect(__ROOT__.'/game', 0, '');
           return;
        }
        $pg = $this->_param('pg');
        $result = D("Result");
        $this->assign("db_result",$result->getResult($LID,$pg));

        $this->initCom($LID,$result->getCount($LID),("" == $pg)? 1 : $pg);

        $this->display();
    }

    public function pg310(){
        $this->assign('GAME_TAB',2);
        $LID = $this->_param('LID');
        if ("" == $LID) {
           redirect(__ROOT__.'/game/pg310', 0, '');
           return;
        }
        $pg = $this->_param('pg');
        $result = D("Result310");
        $this->assign("db_result",$result->getResult($LID,$pg));

        $this->initCom($LID,$result->getCount($LID),("" == $pg)? 1 : $pg);

        $this->display();
    }

    public function initCom($LID,$db_data_cnt, $cur_pg){
        /***************以下赋值后期考虑依缓存实现*******************/
        $arr['open_num'] = 18;
        $arr['rate']     = 24.125;
        $arr['time']     = "2014-05-06 12:45";
        $arr['all_down']     = 25415;  //投注总数
        $arr['all_people']     = 1254;  //中奖人数
        /***********************************************************/
        $arr['LID'] = $LID;    //总数
        $arr['db_data_cnt'] = $db_data_cnt;    //总数
        $arr['cur_pg']      = $cur_pg; //当前页
        $arr['items']       = 10; //每页显示的条数
        $this->assign($arr);
    }
}