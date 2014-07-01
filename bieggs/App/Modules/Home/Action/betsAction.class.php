<?php
class betsAction extends loginAction{
    function _initialize() {
        parent::_initialize();
        $this->assign('PAGE_CURID',4);
    }

    public function index(){
        $LID = $this->_param('LID');
        if ("" == $LID) {
           redirect(__ROOT__.'/game', 0, '');
           return;
        }
        //用户已投注信息
        $userBets = D("UserBets");
        $this->assign("db_user_bets",$userBets->getDataByLid($LID));
        //上期末开奖结果
        $pc28 = D("Pc28");
        $this->assign("db_pc28_last",$pc28->getLastRecord('id,open_num'));
        //自投模式
        $uMode = D("Umode");
        $this->assign("db_umode",$uMode->getNameList());

        $this->display();
    }

    public function psbets(){
        $LID = $this->_param('LID');
        if ("" == $LID) {
           redirect(__ROOT__.'/game', 0, '');
           return;
        }
        //用户已投注信息
        $userBets = D("UserBets");
        $this->assign("db_user_bets",$userBets->getDataByLid($LID));
        //当期开奖结果
        /***************以下赋值后期考虑依缓存实现*******************/
        $rate = "941.62,338.43,169.20,103.96,67.96,48.27,35.57,27.44,22.17,18.11,15.84,14.02,13.67,13.21,13.30,13.70,14.46,15.81,18.07,22.21,27.43,35.84,48.71,67.61,102.25,178.81,333.39,589.64";
        $arr['open_num'] = 15;
        $arr['rate']     = $rate;
        $arr['time']     = "2014-05-06 12:45";
        /***********************************************************/
        $this->assign($arr);

        $this->display();
    }

    public function pc28bets(){

        Log::record("------------------>" . $this->_param('LID'));
        Log::record("------------------>" . $this->_param('CTIME'));
        Log::record("------------------>" . $this->_param('Cheat'));
        Log::record("------------------>" . $this->_param('isdb_p'));
        Log::record("------------------>" . $this->_param('ALLSMONEY'));
        Log::record("------------------>" . $this->_param('SMONEYSUM'));
        Log::record("------------------>" . $this->_param('lastgain'));
        Log::record("------------------>" . $this->_param('_issue'));


        redirect(__ROOT__.'/game', 1, '恭喜！投注成功。');
    }

    public function userMode(){
        $id = $this->_param('id');
        $uMode = D("Umode");
        $res = $uMode->getSpecMode($id);
        $this->ajaxReturn($res[0]['U_ALLSMONEY']);
    }

}