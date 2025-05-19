import type { ApiResult } from "./ApiResult";
import type { IBaseDto } from "./IBasedto";

export interface ApiDataResult<T extends IBaseDto> extends ApiResult {
  data: T;
}

