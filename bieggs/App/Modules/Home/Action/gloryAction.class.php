<?php
class gloryAction extends comAction{
    function _initialize() {
        parent::_initialize();
        $this->assign('PAGE_CURID',8);
    }

    public function index(){
    	$m_tab = $this->_param("tab");
    	$tab = (is_nil($m_tab))? 0: $m_tab;

        $pg = $this->_param('pg');
        $glorylist = D("Glorylist");
        $this->initCom($glorylist->getCount(),("" == $pg)? 1 : $pg);
        $this->assign("db_glorylist",$glorylist->getResultByPage($pg));

    	$this->assign("m_tab",$tab);
        $this->display();
    }

    public function detail(){
        $id = $this->_param('id');  //根据id具体展示

        $this->display();
    }

    private function initCom($db_data_cnt, $cur_pg){
        $array['db_data_cnt'] = $db_data_cnt;    //总数
        $array['cur_pg']      = $cur_pg; //当前页
        $array['items']      = 10; //每页显示的条数
        $this->assign($array);
    }
}