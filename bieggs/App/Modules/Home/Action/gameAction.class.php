<?php
class gameAction extends Action{
    public function index(){
    	$this->assign('PAGE_CURID',4);
        $this->display();
    }

    public function pg310(){
    	$this->assign('PAGE_CURID',4);
        $this->display();
    }

    public function pgstar(){
    	$this->assign('PAGE_CURID',4);
        $this->display();
    }
}