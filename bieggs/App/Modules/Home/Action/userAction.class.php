<?php

class userAction extends Action{
    public function index(){
    	$this->assign('curID',7);
        $this->display();
    }

}