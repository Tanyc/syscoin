<?php

class bbsAction extends Action{
    public function index(){
    	$this->assign('curID',9);
        $this->display();
    }

}