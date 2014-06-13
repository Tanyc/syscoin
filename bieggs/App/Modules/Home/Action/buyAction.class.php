<?php

class buyAction extends comAction{
    public function index(){
    	$this->assign('PAGE_CURID',3);
        $this->display();
    }
}