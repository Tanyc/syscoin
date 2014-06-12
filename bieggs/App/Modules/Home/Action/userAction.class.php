<?php

class userAction extends Action{
    public function index(){
    	$this->assign('PAGE_CURID',7);
        $this->display();
    }

}