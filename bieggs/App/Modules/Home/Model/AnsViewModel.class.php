<?php
class AnsViewModel extends ViewModel {
	const PERPAGE = 10;
    public $viewFields = array(
     	'Ans'=>array('id','blog_id','UID','content','CTIME','_type'=>'LEFT'),
     	'User'=>array('nick','headimg','selfdes', '_on'=>'Ans.UID=User.id'),
    );

    public function getPageResultsByBlogId($id,$page=1){
        return $this->where("blog_id=".$id)->page($page,$this::PERPAGE)->select();
    }

    // public function getCountByType($type){
    //     return $this->where("type=".$type)->count();
    // } 

    // public function getResultById($id){
    //     return $this->where("id=".$id)->find();
    // }

    // public function addOneItem($data){
    //     return $this->add($data);
    // }

}