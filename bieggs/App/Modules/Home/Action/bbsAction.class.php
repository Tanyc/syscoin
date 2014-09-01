<?php

class bbsAction extends comAction{
	function _initialize() {
        parent::_initialize();
        $this->assign('PAGE_CURID',9);
    }

    public function index(){
        $type = $this->_param("navi_tab") ? $this->_param("navi_tab") : 1;
        $page     = $this->_param("pg") ? $this->_param("pg") : 1;
        $this->assign("navi_tab",$type);

        $blog_view = D("BlogView");
        $result = $blog_view->getPageResultByType($type,$page);
        $this->assign("db_bbs",$result);

        $this->initCom($blog_view->getCountByType($type),$page);

        $this->display();
    }

    public function desc(){
        $id = $this->_param("id");
        if (isNil($id)) {
            $this->error("错误！");
        }

        $blog_view = D("BlogView");
        $result = $blog_view->getResultById($id);
        if (isNil($result)) {
            $this->error("查无此帖");
        }
        $this->assign("navi_tab",$result["type"]);
        $this->assign("db_bbs",$result);

        //评论
        $ans_view = D("AnsView");
        $pg = $this->_param('pg')? $this->_param('pg') : 1;
        $ans_result = $ans_view->getPageResultsByBlogId($id,$pg);
        $this->assign("db_ans",$ans_result);

        $this->display();

        // var_dump($result);
    }

    private function initCom($db_data_cnt, $cur_pg){
        $array['db_data_cnt'] = $db_data_cnt;    //总数
        $array['cur_pg']      = $cur_pg; //当前页
        $array['items']      = 10; //每页显示的条数
        $this->assign($array);
    }

    public function pjudge(){
        $this->display();
    }

    public function newAns(){
        var_dump("zheshi ");
    }
}