<?php
class BlogViewModel extends ViewModel {
	const PERPAGE = 15;
    public $viewFields = array(
     	'Bbs'=>array('id','type','title','content','imgs','is_ding','is_good','ans_num','CTIME','_type'=>'LEFT'),
     	'User'=>array('nick','headimg','selfdes','_on'=>'Bbs.UID=User.id'),
    );

    public function getPageResultByType($type,$page){
        return $this->where("type=".$type)->page($page,$this::PERPAGE)->order('is_ding desc')->select();
    }

    public function getCountByType($type){
        return $this->where("type=".$type)->count();
    } 

    public function getResultById($id){
        return $this->where('Bbs.id='.$id)->find();
    }
}