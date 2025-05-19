import type ApiResultStatus from "../ComplexInterfaces/ApiResultStatus";
import type { ErrorModel } from "../ComplexInterfaces/ErrorModel";

export interface ApiResult {
  messages: string;
  status: ApiResultStatus;
  validationErrors?: ErrorModel[]; // opsiyonel olabilir
}
