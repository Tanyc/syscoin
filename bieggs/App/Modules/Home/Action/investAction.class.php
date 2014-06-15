<?php
class investAction extends comAction{
    public function index(){
    	$this->assign('PAGE_CURID',10);
        $this->display();
    }
}