<?php
class prizeAction extends Action{
    public function index(){
    	$this->assign('PAGE_CURID',6);
        $this->display();
    }
}