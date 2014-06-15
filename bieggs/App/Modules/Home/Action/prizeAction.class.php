<?php
class prizeAction extends comAction{
    public function index(){
    	$this->assign('PAGE_CURID',6);
        $this->display();
    }
}