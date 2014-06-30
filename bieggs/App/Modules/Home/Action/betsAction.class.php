<?php
class betsAction extends loginAction{

    public function index(){

        $LID = $this->_param('LID');
        if ("" == $LID) {
           redirect(__ROOT__.'/game', 0, '');
           return;
        }
        //用户已投注信息
        $userBets = D("UserBets");
        $this->assign("db_user_bets",$userBets->getData($LID));
        //上期末开奖结果
        $pc28 = D("Pc28");
        $this->assign("db_pc28_last",$pc28->getLastRecord('id,open_num'));
        //自投模式
        $uMode = D("Umode");
        $this->assign("db_umode",$uMode->getNameList());

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