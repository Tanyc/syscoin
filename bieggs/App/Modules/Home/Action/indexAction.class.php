<?php

class indexAction extends Action{
    public function index(){
        $Model  =   D('Notice');
        $this->assign('notice',$Model->getList());
        /***************************************/
        $ModelPrize = D('Prize');
        $this->assign('prize',$ModelPrize->getList(6,"id,prize_num,name,cost_eggs,swap_num"));
        $this->assign('curID',1);

        $this->display();
    }

    public function read($id=0){
        $Model  =   D('Form');
        $this->assign('vo',$Model->getDetail($id));
        $this->display();
    }
}