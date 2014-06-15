<?php
class gloryAction extends comAction{
    public function index(){
    	$this->assign('PAGE_CURID',8);
        $this->display();
    }
}