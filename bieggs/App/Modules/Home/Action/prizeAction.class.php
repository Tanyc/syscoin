<?php
class prizeAction extends comAction{
    public function index(){
    	$this->assign('PAGE_CURID',6);
        $this->display();
    }

    //查询商品列表
    public function plist(){
    	$id = $this->_param('id');
    	$cid = $this->_param('cid');
    	$pg = ("" == $this->_param('pg'))? 1 : $this->_param('pg');

    	$prize = D("Prize");
    	$this->assign("db_prize",$prize->getResultByPage($pg,$id,$cid));
    	$this->initCom($prize->getCount($id,$cid),$pg);

    	$this->display();
    }

    //访问具体的某个商品
    public function pdesc(){
        $pid = $this->_param("pid");
        $prize = D("Prize");
        $this->assign("db_prize",$prize->getSpecPro($pid));

        $this->display();
    }

    private function initCom($db_data_cnt, $cur_pg){
        $array['db_data_cnt'] = $db_data_cnt;    //总数
        $array['cur_pg']      = $cur_pg; //当前页
        $array['items']      = 20; //每页显示的条数
        $this->assign($array);
    }
}