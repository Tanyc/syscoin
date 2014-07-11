<?php
class gloryAction extends comAction{
    public function index(){
    	$this->assign('PAGE_CURID',8);
    	$m_tab = $this->_param("tab");
    	$tab = (is_nil($m_tab))? 0: $m_tab;

    	$this->initCom(70,2);  //测试后删除

    	$this->assign("m_tab",$tab);
        $this->display();
    }

    public function initCom($db_data_cnt, $cur_pg){
        $array['db_data_cnt'] = $db_data_cnt;    //总数
        $array['cur_pg']      = $cur_pg; //当前页
        $array['items']      = 20; //每页显示的条数
        $this->assign($array);
    }
}