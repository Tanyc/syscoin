<?php

class bbsAction extends Action{
    public function index(){
    	$this->assign('PAGE_CURID',9);
        $this->display();
    }

}