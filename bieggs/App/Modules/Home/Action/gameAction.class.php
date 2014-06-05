<?php
class gameAction extends Action{
    public function index(){
    	$this->assign('curID',4);
        $this->display();
    }

    public function pg310(){
    	$this->assign('curID',4);
        $this->display();
    }

    public function pgstar(){
    	$this->assign('curID',4);
        $this->display();
    }
}