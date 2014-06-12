<?php
class gloryAction extends Action{
    public function index(){
    	$this->assign('PAGE_CURID',8);
        $this->display();
    }
}