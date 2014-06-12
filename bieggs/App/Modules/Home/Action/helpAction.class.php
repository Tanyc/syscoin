<?php

class helpAction extends Action{
    public function index(){
    	$this->assign('PAGE_CURID',11);
        $this->display();
    }

}