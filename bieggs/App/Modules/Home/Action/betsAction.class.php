<?php
class betsAction extends loginAction{

    public function index(){

        $LID = $this->_param('LID');
        Log::record("front LID = ".$LID);
        $userBets = D("UserBets");
        $this->assign("db_user_bets",$userBets->getData($LID));

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


        redirect(__ROOT__.'/index', 1, '恭喜！投注成功。');
    }

}