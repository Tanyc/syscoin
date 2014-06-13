<?php

class bbsAction extends comAction{
    public function index(){
    	$this->assign('PAGE_CURID',9);
        $this->display();
    }

}