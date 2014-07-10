<?php
class PrizeModel extends Model {
	const PERPAGE = 20;
    public function getList($count=6,$field){
    	if ($field) {
    		return $this->field($field)->limit($count)->select();
    	}
    	return $this->field(true)->limit($count)->select();
    }

    public function getResultByPage($page = 1,$type_id, $subtype_id){
    	if (is_nil($page)) {
    		$page = 1;
    	}
    	$where = $this->genWhere($type_id, $subtype_id);
        return $this->where($where)->page($page,$this::PERPAGE)->select();
    }

    public function getSpecPro($pid){
        return $this->where("id=".$pid)->select();
    }

    public function getCount($type_id, $subtype_id){
    	$where = $this->genWhere($type_id, $subtype_id);
        return $this->where($where)->count();
    }

    private function genWhere($type_id, $subtype_id){
    	$where = "";
    	if (!is_nil($type_id)) {
    		if (!is_nil($subtype_id)) {
    			$where = "type_id=" . $type_id . " and subtype_id=".$subtype_id;
    		}else{
    			$where = "type_id=" . $type_id;
    		}
    	}
    	return $where;
    }
}