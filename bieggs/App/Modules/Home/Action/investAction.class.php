<?php
class investAction extends Action{
    public function index(){
    	$this->assign('PAGE_CURID',10);
        $this->display();
    }
}