<?php
class investAction extends comAction{
	function _initialize() {
        parent::_initialize();
        $this->assign('PAGE_CURID',10);
    }

    public function index(){
    	$db_invite = D("Invite");
    	$this->assign("db_top10",$db_invite->top10());
    	$this->assign("db_newer10",$db_invite->newer10());
        $this->display();

    	// $test = $db_invite->newer10();
        // var_dump($test[0]["UID"]);
    }
}