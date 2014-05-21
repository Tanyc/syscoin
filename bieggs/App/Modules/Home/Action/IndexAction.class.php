<?php
// +----------------------------------------------------------------------
// | TOPThink [ WE CAN DO IT JUST THINK ]
// +----------------------------------------------------------------------
// | Copyright (c) 2011 http://topthink.com All rights reserved.
// +----------------------------------------------------------------------
// | Licensed ( http://www.apache.org/licenses/LICENSE-2.0 )
// +----------------------------------------------------------------------
// | Author: liu21st <liu21st@gmail.com>
// +----------------------------------------------------------------------
// $Id$

class IndexAction extends Action{
    public function index(){
        $Model  =   D('Notice');
        $this->assign('notice',$Model->getList());
        /***************************************/
        $ModelPrize = D('Prize');
        $this->assign('prize',$ModelPrize->getList(6,"id,prize_num,name,cost_eggs,swap_num"));

        $this->display();
    }

    public function read($id=0){
        $Model  =   D('Form');
        $this->assign('vo',$Model->getDetail($id));
        $this->display();
    }
}