<?php

class buyAction extends Action{
    public function index(){
    	$this->assign('PAGE_CURID',3);
        $this->display();
    }
}