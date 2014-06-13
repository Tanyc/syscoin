<?php

class helpAction extends comAction{
    public function index(){
    	$this->assign('PAGE_CURID',11);
        $this->display();
    }

}