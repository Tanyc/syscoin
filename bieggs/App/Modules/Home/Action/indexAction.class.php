<?php

class indexAction extends comAction{
    public function index(){
        $mNotice  =   D('Notice');
        $this->assign('notice',$mNotice->getList());
        /***************************************/
        $mActivity  =   D('Activity');
        $this->assign('activity',$mActivity->getList());
        /***************************************/
        $mPrize = D('Prize');
        $this->assign('prize',$mPrize->getList(6,"id,prize_num,name,cost_eggs,swap_num"));
        $this->assign('PAGE_CURID',1);

        $this->display();
    }

    public function index_test(){ //测试后删除
        $this->display();
    }

    public function read($id=0){
        $Model  =   D('Form');
        $this->assign('vo',$Model->getDetail($id));
        $this->display();
    }
}