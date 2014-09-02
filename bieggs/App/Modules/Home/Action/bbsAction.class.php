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

        $this->assign("blog_id",$id);

        $this->display();

        // $test = "this           is
        //  a test";
        // $re = covBBSContent($test);
        // var_dump($re);
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

    private function hasFiles($files) {
        if (empty($_FILES)) {
            return false;
        }
        foreach ($files as $key=>$file){
            if("" != $file['name']) {
                return true;
            }
        }
       return false;
    }

    public function newAns(){
        if (checkIsLogin()) {
            if ($this->hasFiles($_FILES)) {
                $this->_upload();
            }else{
                $this->saveAns();
            }
        }
    }

    private function saveAns($files){
        $db_ans = M("Ans");
        $data            = array();
        $data['blog_id'] = $_POST["blog_id"];
        $data['UID']     = $_SESSION[C('USER_AUTH_KEY')];
        $data['content'] = covBBSContent($_POST["content"]);
        if (!isNil($files)) {
            $data['imgs']    = substr($files, 0, -1);
        }
        $data['CTIME']   = time();
        $isadd = $db_ans->add($data);
        if ($isadd !== false) {
            $this->success('评论成功！');
        } else {
            $this->error('系统忙，请稍后再试!');
        }
    }

    // 文件上传
    protected function _upload() {
        import('@.ORG.Util.UploadFile');
        $upload = new UploadFile();
        $upload->maxSize            = 3292200;
        $upload->allowExts          = explode(',', 'jpg,gif,png,jpeg');
        $upload->savePath           = './Uploads/Images/BBS/';
        $upload->thumb              = true;
        $upload->imageClassPath     = '@.ORG.Util.Image';
        $upload->thumbPrefix        = 'm_,s_'; 
        $upload->thumbMaxWidth      = '400,100';
        $upload->thumbMaxHeight     = '400,100';
        $upload->saveRule           = 'uniqid';
        $upload->thumbRemoveOrigin  = true;
        if (!$upload->upload()) {
            $this->error($upload->getErrorMsg());
        } else {
            $uploadList = $upload->getUploadFileInfo();
            import('@.ORG.Util.Image');
            $path = $uploadList[0]['savepath'];
            $files = "";
            foreach ($uploadList as $s_file) {
                $fileName = 'm_' . $s_file['savename'];
                if ("" != $fileName) {
                    Image::water($path . $fileName, './Public/logo/logo.png');
                    $files .= $fileName . ":";
                }
            }
            $this->saveAns($files);
        }
    }
}