<?php

class helpAction extends Action{
    public function index(){
    	$this->assign('curID',11);
        $this->display();
    }

}